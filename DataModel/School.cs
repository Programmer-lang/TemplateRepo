namespace DataModel
{
   
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Collections.Specialized;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    //[Table("dbo.School")]
    public  class School:EntityBase
    {
        public School()
        {
            Teachers = new ObservableCollection<Teacher>();
           // Teachers.CollectionChanged += this.OnCollectionChanged;
         }

        public decimal SchoolID { get; set; }

    

        private string schoolName;

        [StringLength(50)]
        public string SchoolName
        {
            get
            {
                return schoolName;
            }

            set
            {
                if (schoolName != value)
                {
                    schoolName = value;
                    OnPropertyChanged();
                }
            }
        }

        private string director;

        [StringLength(50)]
        public string Director
        {
            get
            {
                return director;
            }

            set
            {
                if (director != value)
                {
                    director = value;
                    OnPropertyChanged();
                }
            }
        }

      

       public virtual ObservableCollection<Teacher> Teachers { get; set; }

        
    }
}
