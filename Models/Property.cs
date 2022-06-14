

namespace PropertyTracker.Models
{
    public class Property
    {

        public Property()
        {
            this.DateTimeModified = DateTime.Now;
        }

        public DateTime DateTimeModified { get; private set; }
        public Guid Id { get; set; } = new Guid();
        public string? Name { get; set; }
     //   public double SizeLength { get; set; }
      //  public double SizeWidth { get; set; }
        public double Cost { get; set; }
        public double Value { get; set; }
        public List<Building>? Buildings { get; set; }

        public List<Garden>? Gardens { get; set; }

        public List<Pond>? Ponds { get; set; }

        public List<Renovation> Renovations = new();

        public double Acreage { get; set; }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }


         public List<Renovation> renovations = new();


    }

 }


   

