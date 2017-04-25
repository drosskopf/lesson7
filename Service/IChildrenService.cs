using System.Collections.Generic;

namespace webapp
{

    public interface IChildrenService
    {
        IList<Child> Get();
        Child Get(int id);
        Child Create(Child child);
    }
}