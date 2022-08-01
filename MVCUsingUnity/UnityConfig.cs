using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace MVCUsingUnity
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            DependencyResolver.SetResolver(new UnityDependencyResolver
                (container));
        }
    }
}
