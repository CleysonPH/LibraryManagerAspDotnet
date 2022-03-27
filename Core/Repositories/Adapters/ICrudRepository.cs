namespace LibraryManager.Core.Repositories;

public interface ICrudRepository<Model, ID>
{
    IEnumerable<Model> FindAll();
    Model Create(Model model);
    Model FindById(ID id);
    Model UpdateById(ID id, Model model);
    void DeleteById(ID id);
}