using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ZeroPlay.Control
{
    public sealed partial class LoginDialogContent : UserControl
    {
        public string LoginUsername => LoginUsernameBox.Text;
        public string LoginPassword => LoginPasswordBox.Password;

        public string RegisterUsername => RegisterUsernameBox.Text;
        public string RegisterPassword => RegisterPasswordBox.Password;
        public string ConfirmPassword => ConfirmPasswordBox.Password;

        public bool IsLogin = false;

        public bool IsCancelled = false;

        public LoginDialogContent()
        {
            this.InitializeComponent();
        }

        // ��¼��ť����¼�
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(LoginUsername) || String.IsNullOrWhiteSpace(LoginPassword))
            {
                LoginErrorTip.Text = "�û��������벻��Ϊ��";
                LoginErrorTip.Visibility = Visibility.Visible;
                return;
            }

            IsLogin = true;
            ((ContentDialog)Parent).Hide();
        }

        private void Cancellation_Click(object sender, RoutedEventArgs e)
        {
            IsCancelled = true;
            ((ContentDialog)Parent).Hide();
        }

        // ע�ᰴť����¼�
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            // ��֤�����ȷ�������Ƿ�һ��
            if (RegisterPassword != ConfirmPassword)
            {
                RegisterErrorTip.Text = "�û��������벻��Ϊ��";
                RegisterErrorTip.Visibility = Visibility.Visible;
                return;
            }

            if (RegisterPassword.Length <= 6)
            {
                RegisterErrorTip.Text = "���볤�Ȳ���С�� 6 λ";
                RegisterErrorTip.Visibility = Visibility.Visible;
                return;
            }

            IsLogin = false;
            ((ContentDialog)Parent).Hide();
        }
    }
}
