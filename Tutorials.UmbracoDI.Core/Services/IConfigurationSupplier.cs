namespace Tutorials.UmbracoDI.Core.Services
{
    public interface IConfigurationSupplier
    {
        string DazzleString { get; }
        string HostEmailAddress { get; }
    }
}