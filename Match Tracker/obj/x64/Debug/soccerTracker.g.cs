﻿#pragma checksum "C:\Users\MartinColeman\Documents\GitHub\MobileAppsProject\Match Tracker\soccerTracker.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9C4ED28DEEAA45CCF53577563A1B6EB6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Match_Tracker
{
    partial class soccerTracker : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.HeaderGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.Team1Grid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3:
                {
                    this.Team2Grid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4:
                {
                    this.score1 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 5:
                {
                    this.score2 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 6:
                {
                    this.footerGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 7:
                {
                    this.SaveButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 72 "..\..\..\soccerTracker.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SaveButton).Click += this.SaveButton_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.goalButton2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 66 "..\..\..\soccerTracker.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.goalButton2).Click += this.goalButton2_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.goal2RemoveButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 67 "..\..\..\soccerTracker.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.goal2RemoveButton).Click += this.goal2RemoveButton_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.goal2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.goalRemoveButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 52 "..\..\..\soccerTracker.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.goalRemoveButton).Click += this.goalRemoveButton_Click;
                    #line default
                }
                break;
            case 12:
                {
                    this.goalButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 49 "..\..\..\soccerTracker.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.goalButton).Click += this.goalButton_Click;
                    #line default
                }
                break;
            case 13:
                {
                    this.goal1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.teamTwoName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 35 "..\..\..\soccerTracker.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.teamTwoName).Tapped += this.teamTwoName_Tapped;
                    #line default
                }
                break;
            case 15:
                {
                    this.teamOneName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 31 "..\..\..\soccerTracker.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.teamOneName).Tapped += this.teamOneName_Tapped;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

