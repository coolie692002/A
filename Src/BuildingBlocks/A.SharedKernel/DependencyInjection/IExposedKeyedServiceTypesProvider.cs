namespace A.SharedKernel.DependencyInjection;

public interface IExposedKeyedServiceTypesProvider
{
    ServiceIdentifier[] GetExposedServiceTypes(Type targetType);
}
