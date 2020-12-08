using System;

namespace SpoRT.Domain.Models
{
    public class Sport : BaseModel
    {
        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                SetStateEdited();
                UpdatedAt = DateTime.Now;
            }
        }

        protected Sport()
        {
        }

        public Sport(string name) : base()
        {
            Name = name;
        }
    }
}