namespace csharp_practice.exercises.Interface;

public interface ISaveable
{
    List<String> Write();
    void Read(List<String> list);
}