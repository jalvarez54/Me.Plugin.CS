using System;
using System.Collections;
using System.IO;
using System.Reflection;

namespace Me.Plugin.ServiceInterface
{
    public class ServicesPlugin
    {

        private const string CLASS_BASE = "Me.Plugin.Base";

        public struct PluginPresent
        {
            public string PathAssembly;
            public string NameClasse;
        }

        public static PluginPresent[] GetPlugins(string cheminDlls, string piInterface)
        {
            ArrayList listPlugins = new ArrayList();
            string[] listeDlls = null;
            int index = 0;
            Assembly dllAssembly = default(Assembly);

            cheminDlls = cheminDlls + "\\Plugin";
            // Get all dlls.
            listeDlls = Directory.GetFileSystemEntries(cheminDlls, "*.dll");
            for (index = 0; index <= listeDlls.Length - 1; index++)
            {
                try
                {
                    dllAssembly = Assembly.LoadFrom(listeDlls[index]);
                    ExaminerAssembly(dllAssembly, piInterface, listPlugins);
                }
                catch (Exception)
                {
                    // Nothing to do.
                }
            }

            // Retourner tous les plugins trouvés.
            PluginPresent[] listePluginPresents = new PluginPresent[listPlugins.Count];

            if (listPlugins.Count != 0)
            {
                listPlugins.CopyTo(listePluginPresents);
                return listePluginPresents;
            }
            else {
                return null;
            }

        }

        private static void ExaminerAssembly(Assembly dllAssembly, string piInterface, ArrayList plugins)
        {
            Type typeInterface;
            PluginPresent plugin = default(PluginPresent);

            foreach (Type item in dllAssembly.GetTypes())
            {
                // Public types only
                if (item.IsPublic == true)
                {
                    // Ignore abstract class.
                    if (!((item.Attributes & TypeAttributes.Abstract) == TypeAttributes.Abstract))
                    {
                        // Is our Interface implemented ?
                        typeInterface = item.GetInterface(piInterface, true);

                        // If Not (typeInterface Is Nothing) And typePresent.FullName <> CLASS_BASE Then
                        if ((typeInterface != null))
                        {
                            // Yes he implement.
                            plugin = new PluginPresent();
                            plugin.PathAssembly = dllAssembly.Location;
                            plugin.NameClasse = item.FullName;
                            plugins.Add(plugin);
                        }

                    }
                }
            }

        }

        public static object CreatePluginInstance(PluginPresent plugin)
        {
            Assembly dllAssembly = default(Assembly);
            object objPlugin = null;

            try
            {
                dllAssembly = Assembly.LoadFrom(plugin.PathAssembly);

                objPlugin = dllAssembly.CreateInstance(plugin.NameClasse);
            }
            catch (Exception)
            {
                return null;
            }

            return objPlugin;

        }

    }
}
