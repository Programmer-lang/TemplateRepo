﻿using DataModel;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolTemplate.SchoolDBContextDataModel {

    /// <summary>
    /// A SchoolDBContextDesignTimeUnitOfWork instance that represents the design-time implementation of the ISchoolDBContextUnitOfWork interface.
    /// </summary>
    public class SchoolDBContextDesignTimeUnitOfWork : DesignTimeUnitOfWork, ISchoolDBContextUnitOfWork {

        /// <summary>
        /// Initializes a new instance of the SchoolDBContextDesignTimeUnitOfWork class.
        /// </summary>
        public SchoolDBContextDesignTimeUnitOfWork() {
        }

        IRepository<Course, decimal> ISchoolDBContextUnitOfWork.Courses {
            get { return GetRepository((Course x) => x.CourseID); }
        }

        IRepository<Student, decimal> ISchoolDBContextUnitOfWork.Students {
            get { return GetRepository((Student x) => x.StudentID); }
        }

        IRepository<School, decimal> ISchoolDBContextUnitOfWork.Schools {
            get { return GetRepository((School x) => x.SchoolID); }
        }

        IRepository<Department, decimal> ISchoolDBContextUnitOfWork.Departments {
            get { return GetRepository((Department x) => x.DepartmentID); }
        }

        IRepository<Teacher, decimal> ISchoolDBContextUnitOfWork.Teachers {
            get { return GetRepository((Teacher x) => x.TeacherID); }
        }

        IRepository<Vehicule, decimal> ISchoolDBContextUnitOfWork.Vehicules {
            get { return GetRepository((Vehicule x) => x.VehiculeID); }
        }

        public List<MenuIDHistory> GetMenuIDHistoryData(string p_sQuery)
        {
            return null;
        }
    }
}
