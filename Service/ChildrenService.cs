using System.Collections.Generic;
using System.Linq;

namespace webapp
{
    public class ChildrenService:IChildrenService
    {
        private IList<Child> _children {get;set;}
        public ChildrenService(){
            _children =new List<Child>(){
                new Child(1,"Alex",15),
                new Child(2,"Brad",11),
                new Child(3,"Summer",10),
                new Child(4,"Jeremy",7)
            }; 
        }
        public IList<Child> Get(){
            return _children;
        }
        public Child Get(int id){
            return _children.Where(c=>c.Id ==id).First();
        }
        public Child Create(Child child){
            var nextId = _children.Max(c=>c.Id)+1;
            child.Id = nextId;
           _children.Add(child);
           return child;
        }

    }
}