//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookBorrowFee
    {
        public BookBorrowFee()
        {
            this.BorrowedBooks = new HashSet<BorrowedBooks>();
        }
    
        public int BookBorrowFeeID { get; set; }
        public string BorrowFee { get; set; }
        public bool IsActive { get; set; }
        public int NumberOfDateBorrowed { get; set; }
    
        public virtual ICollection<BorrowedBooks> BorrowedBooks { get; set; }
    }
}
