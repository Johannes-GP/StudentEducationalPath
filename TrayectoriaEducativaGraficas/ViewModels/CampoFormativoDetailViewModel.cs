using CommunityToolkit.Mvvm.ComponentModel;
using TrayectoriaEducativaGraficas.Models;

namespace TrayectoriaEducativaGraficas.ViewModels
{
    public partial class CampoFormativoDetailViewModel : ObservableObject, IQueryAttributable
    {
        [ObservableProperty]
        private CampoFormativo campoFormativoObject;

        public CampoFormativoDetailViewModel()
        {

        }

        public void ApplyQueryAttributes(IDictionary<string, object> queryAttributes)
        {
            if (queryAttributes.ContainsKey("CampoFormativo"))
            {
                CampoFormativoObject = queryAttributes["CampoFormativo"] as CampoFormativo;
            }
        }
    }
}
