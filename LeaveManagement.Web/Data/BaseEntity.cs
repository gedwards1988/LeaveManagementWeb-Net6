namespace LeaveManagement.Web.Data
{
    // Cannot do it by itself - every table we create will have these base columns
    public abstract class BaseEntity
    {
        // 1. Always have a Primary Key - Auto Increments
        public int Id { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }
    }
}
