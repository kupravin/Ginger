#region License
/*
Copyright © 2014-2018 European Support Limited

Licensed under the Apache License, Version 2.0 (the "License")
you may not use this file except in compliance with the License.
You may obtain a copy of the License at 

http://www.apache.org/licenses/LICENSE-2.0 

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS, 
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
See the License for the specific language governing permissions and 
limitations under the License. 
*/
#endregion

using Amdocs.Ginger.Common;
using Amdocs.Ginger.CoreNET.SolutionRepositoryLib.RepositoryObjectsLib.ActionsLib.Common;
using Amdocs.Ginger.Repository;
using Ginger;
using GingerWPF.WizardLib;
using System.Windows.Controls;

namespace GingerWPF.PluginsLib.AddPluginWizardLib
{
    /// <summary>
    /// Interaction logic for PluginInfoPage.xaml
    /// </summary>
    public partial class PlugPackageinInfoPage : Page, IWizardPage
    {
        PluginPackage mPluginPackage;

        public PlugPackageinInfoPage(PluginPackage pluginPackage)
        {
            InitializeComponent();         
            
            mPluginPackage = pluginPackage;            
        }

        public void WizardEvent(WizardEventArgs WizardEventArgs)
        {
            switch(WizardEventArgs.EventType)
            {
                case EventType.Init:
                    NameTextBox.BindControl(mPluginPackage, nameof(PluginPackage.PluginID));
                    FolderTextBox.BindControl(mPluginPackage, nameof(PluginPackage.Folder));
                    break;
                case EventType.Active:
                    ObservableList<StandAloneAction> actions = mPluginPackage.GetStandAloneActions();
                    ActionsDataGrid.ItemsSource = actions;

                    ServicesGrid.ItemsSource = 
                    break;

            }
            
        }

        private void PluginsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void ServicesGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
