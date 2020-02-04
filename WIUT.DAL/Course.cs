namespace WIUT.DAL
{
    public class Course
    {
        private string _name;

        public int Id { get; set; }

        public string Name {
            get => _name;
            //set => _name = value;

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new System.Exception("Name cannot be empty");
                _name = value;
            }
        }

        public Course()
        {

        }

        public Course(string name)
        {
            Name = name;
        }
    }
}
