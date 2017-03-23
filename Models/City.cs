using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RateExpert.Models
{
    public class City
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id
        {
            get;
            set;
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
        public string Name
        {
            get;
            set;
        }

        public long StateId
        {
            get;
            set;
        }

        //public State State
        //{
        //    get;
        //    set;
        //}
    }
}
