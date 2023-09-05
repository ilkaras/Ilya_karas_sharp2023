namespace Skeleton.DAL.Entities;

public class UserEntity : BaseEntity
{
    public string Name { get; set; } = default!;
    public string Surname { get; set; } = default!;
    public string Password { get; set; } = default!;
    public virtual ICollection<TestEntity>? Tests { get; set; }
}