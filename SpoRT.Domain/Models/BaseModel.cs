using System;

namespace SpoRT.Domain.Models
{
    public abstract class BaseModel
    {
        public long Id { get; }
        public DateTime CreatedAt { get; }
        public DateTime UpdatedAt { get; protected set; }
        public State State { get; private set; }

        protected BaseModel()
        {
            Id = 0;
            DateTime now = DateTime.Now;
            CreatedAt = now;
            UpdatedAt = now;
            SetStateNew();
        }

        protected BaseModel(long id)
        {
            if (id <= 0)
            {
                throw new Exception("Id has to be greater than 0.");
            }

            Id = id;
            DateTime now = DateTime.Now;
            CreatedAt = now;
            UpdatedAt = now;
            SetStateSaved();
        }

        protected void SetStateNew()
        {
            State = State.New;
        }

        protected void SetStateSaved()
        {
            State = State.Saved;
        }

        protected void SetStateEdited()
        {
            if (State != State.Saved)
            {
                return;
            }
            State = State.Edited;
        }

        public bool IsStatusNew => State == State.New;
        public bool IsStatusSaved => State == State.Saved;
        public bool IsStatusEdited => State == State.Edited;
    }

    public enum State
    {
        New, Saved, Edited
    }
}