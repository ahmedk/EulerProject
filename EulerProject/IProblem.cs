namespace EulerProject
{
    public interface IProblem
    {
        object Solve(params object[] args);
    }
}
