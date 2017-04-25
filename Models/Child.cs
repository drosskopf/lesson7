using System.ComponentModel.DataAnnotations;

namespace webapp{
    public class Child{
        public Child(int id, string name, int age){
            Id=id;
            Name = name;
            Age = age;
        }
        public int Id {get;set;}
        [Required]
        [StringLength(50,MinimumLength=3)]
        public string Name {get;set;}
        [Range(0,120)]
        public int Age {get;set;}
        public string Email {get;set;}
    }
}
