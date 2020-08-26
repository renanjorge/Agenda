namespace Agenda.Domain.Entities 
{
    public class EventType 
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string HexColor { get; set; }
    }
}