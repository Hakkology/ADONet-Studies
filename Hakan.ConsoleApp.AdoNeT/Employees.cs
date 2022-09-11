using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Hakan.ConsoleApp.AdoNeT
{
    public class Employees
    {

        public int employeeIDField;

        public string lastNameField;

        public string firstNameField;

        private string titleField;

        private string titleOfCourtesyField;

        private System.DateTime birthDateField;

        private System.DateTime hireDateField;

        private string addressField;

        private string cityField;

        private string regionField;

        private uint postalCodeField;

        private string countryField;

        private string homePhoneField;

        private ushort extensionField;

        private string photoField;

        private string notesField;

        private byte reportsToField;

        private string photoPathField;

        /// <remarks/>
        public int EmployeeID
        {
            get
            {
                return this.employeeIDField;
            }
            set
            {
                this.employeeIDField = value;
            }
        }

        /// <remarks/>
        public string LastName
        {
            get
            {
                return this.lastNameField;
            }
            set
            {
                this.lastNameField = value;
            }
        }

        /// <remarks/>
        public string FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        public string Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public string TitleOfCourtesy
        {
            get
            {
                return this.titleOfCourtesyField;
            }
            set
            {
                this.titleOfCourtesyField = value;
            }
        }

        /// <remarks/>
        public System.DateTime BirthDate
        {
            get
            {
                return this.birthDateField;
            }
            set
            {
                this.birthDateField = value;
            }
        }

        /// <remarks/>
        public System.DateTime HireDate
        {
            get
            {
                return this.hireDateField;
            }
            set
            {
                this.hireDateField = value;
            }
        }

        /// <remarks/>
        public string Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public string Region
        {
            get
            {
                return this.regionField;
            }
            set
            {
                this.regionField = value;
            }
        }

        /// <remarks/>
        public uint PostalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }

        /// <remarks/>
        public string Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        public string HomePhone
        {
            get
            {
                return this.homePhoneField;
            }
            set
            {
                this.homePhoneField = value;
            }
        }

        /// <remarks/>
        public ushort Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }

        /// <remarks/>
        public string Photo
        {
            get
            {
                return this.photoField;
            }
            set
            {
                this.photoField = value;
            }
        }

        /// <remarks/>
        public string Notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
            }
        }

        /// <remarks/>
        public byte ReportsTo
        {
            get
            {
                return this.reportsToField;
            }
            set
            {
                this.reportsToField = value;
            }
        }

        /// <remarks/>
        public string PhotoPath
        {
            get
            {
                return this.photoPathField;
            }
            set
            {
                this.photoPathField = value;
            }
        }
    }


}
