using System.ComponentModel.DataAnnotations;
using DropDownListForEnumDemo.Enumerations;

namespace DropDownListForEnumDemo.Models {

    public class CarsModel {
        [Display(Name = "Select A Car:")]
        [Required(ErrorMessage = "* Required")]
        public Cars? SelectedCar { get; set; }
    }
}