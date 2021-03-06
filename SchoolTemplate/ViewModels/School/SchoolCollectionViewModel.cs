﻿using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using SchoolTemplate.SchoolDBContextDataModel;
using SchoolTemplate.Common;
using DataModel;
using DevExpress.Mvvm;
using System.Collections.ObjectModel;

namespace SchoolTemplate.ViewModels {

    /// <summary>
    /// Represents the Schools collection view model.
    /// </summary>
    public partial class SchoolCollectionViewModel : CollectionViewModel<School, decimal, ISchoolDBContextUnitOfWork> {


        public ObservableCollection<MenuIDHistory> MenuIDHistory { get;  set; }



        public virtual MenuIDHistory SelectedMenuID { get; set; }



        /// <summary>
        /// Creates a new instance of SchoolCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static SchoolCollectionViewModel Create(IUnitOfWorkFactory<ISchoolDBContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new SchoolCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the SchoolCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the SchoolCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected SchoolCollectionViewModel(IUnitOfWorkFactory<ISchoolDBContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Schools, null, null, null, false, UnitOfWorkPolicy.Shared) {
        }


        public override void Edit(School projectionEntity)
        {
            var service = this.GetService<IDocumentManagerService>();
            service.ShowExistingEntityDocument<School, decimal>(this, projectionEntity.SchoolID);


        }

        public void OnInitialized()
        {

            try
            {


                MenuIDHistory = new ObservableCollection<MenuIDHistory>(UnitOfWorkSource.GetUnitOfWorkFactory().CreateUnitOfWork().GetMenuIDHistoryData("usp_GetData " + "Ali"));

            }
            catch (Exception ex)
            {

                MessageBoxService.Show(ex.Message);

            }
        }


        public void EditID()
        {
            var service = this.GetService<IDocumentManagerService>();
            service.ShowExistingEntityDocument<School, decimal>(this, SelectedMenuID.ID);

            SelectedMenuID = null;
        }

    }
}