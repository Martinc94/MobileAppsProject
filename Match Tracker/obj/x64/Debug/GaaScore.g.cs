﻿#pragma checksum "C:\Users\MartinColeman\Documents\GitHub\MobileAppsProject\Match Tracker\GaaScore.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2BB1DD41A40BAB4620B38BF3E47C9046"
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
    partial class GaaScore : 
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
                    #line 103 "..\..\..\GaaScore.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SaveButton).Click += this.SaveButton_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.goal2RemoveButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 97 "..\..\..\GaaScore.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.goal2RemoveButton).Click += this.goal2RemoveButton_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.Point2RemoveButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 98 "..\..\..\GaaScore.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Point2RemoveButton).Click += this.Point2RemoveButton_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.goalButton2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 88 "..\..\..\GaaScore.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.goalButton2).Click += this.goalButton2_Click;
                    #line default
                }
                break;
            case 11:
                {
                    this.PointButton2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 89 "..\..\..\GaaScore.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.PointButton2).Click += this.PointButton2_Click;
                    #line default
                }
                break;
            case 12:
                {
                    this.goal2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.seperator2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.point2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15:
                {
                    this.goalRemoveButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 65 "..\..\..\GaaScore.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.goalRemoveButton).Click += this.goalRemoveButton_Click;
                    #line default
                }
                break;
            case 16:
                {
                    this.PointRemoveButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 66 "..\..\..\GaaScore.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.PointRemoveButton).Click += this.PointRemoveButton_Click;
                    #line default
                }
                break;
            case 17:
                {
                    this.goalButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 56 "..\..\..\GaaScore.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.goalButton).Click += this.goalButton_Click;
                    #line default
                }
                break;
            case 18:
                {
                    this.PointButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 57 "..\..\..\GaaScore.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.PointButton).Click += this.PointButton_Click;
                    #line default
                }
                break;
            case 19:
                {
                    this.goal1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 20:
                {
                    this.seperator = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 21:
                {
                    this.point1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 22:
                {
                    this.teamTwoName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 35 "..\..\..\GaaScore.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.teamTwoName).Tapped += this.teamTwoName_Tapped;
                    #line default
                }
                break;
            case 23:
                {
                    this.teamOneName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 31 "..\..\..\GaaScore.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.teamOneName).Tapped += this.teamOneName_Tapped;
                    #line default
                }
                break;
            case 24:
                {
                    this.Header = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

