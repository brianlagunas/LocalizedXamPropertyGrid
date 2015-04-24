using LocalizedXamPropertyGrid.Resources;

namespace LocalizedXamPropertyGrid
{
    public class Person
    {
        [LocalizedDisplayName("NameDisplayName", typeof(PersonResources))]
        [LocalizedDescription("NameDescription", typeof(PersonResources))]
        [LocalizedCategory("PersonCategory", typeof(PersonResources))]
        public string Name { get; set; }
    }
}