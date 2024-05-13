using expenses.domain.interfaces;

namespace expenses.domain.classes;

public class Base : IBase
{
        public int Id { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool Removed { get; set; }
}
