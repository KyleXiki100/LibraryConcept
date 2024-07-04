using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryConcept
{
    public class LibraryMember
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int borrowedBooks { get; set; }

        public LibraryMember(int id, string Name,int borrowedbooks) {
            Id = id;
            Name = Name;
            borrowedBooks = borrowedbooks;

        }


        public class Authority : LibraryMember
        {
            public string Role { get; set; }

            public Authority(int id,string name,int borrowedbooks,string role):base(id,name,borrowedbooks)
            {
                Role = role;
            }
        }

    }
}
