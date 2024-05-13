using expenses.domain.interfaces;

namespace expenses.domain.entities;

public class BaseClass : IBase
{
        public int Id { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool Removed { get; set; }
}
