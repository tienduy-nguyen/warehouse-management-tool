//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WareHouseManagement.Models
{
    using System;
    using System.Collections.Generic;
    using WarehouseManagement.ViewModel;

    public partial class Object: BaseViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Object()
        {
            this.InputInfoes = new HashSet<InputInfo>();
            this.OutputInfoes = new HashSet<OutputInfo>();
        }

        private string id;
        public string Id { get => id; set { id = value; OnPropertyChanged(); } }
        private string displayName;
        public string DisplayName { get => displayName; set { displayName = value; OnPropertyChanged(); } }

        private int idUnit;
        public int IdUnit { get => idUnit; set { idUnit = value; OnPropertyChanged(); } }
        private int idSupplier;
        public int IdSupplier { get => idSupplier; set { idSupplier = value; OnPropertyChanged(); } }

        public string qRcode;
        public string QRCode { get => qRcode; set { qRcode = value; OnPropertyChanged(); } }
        private string barCode;
        public string BarCode { get => barCode; set { barCode = value; OnPropertyChanged(); } }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InputInfo> InputInfoes { get; set; }
        private Supplier supplier;
        public virtual Supplier Supplier { get => supplier; set { supplier = value; OnPropertyChanged(); } }

        private Unit unit;
        public virtual Unit Unit { get => unit; set { unit = value; OnPropertyChanged(); } }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OutputInfo> OutputInfoes { get; set; }
    }
}
