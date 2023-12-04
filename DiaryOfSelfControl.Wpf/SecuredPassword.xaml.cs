using System.Windows;
using System.Windows.Controls;
using StratumUiPasswordBox = StratumUi.Wpf.Core.AttachedProperties.PasswordBox;

namespace DiaryOfSelfControl.Wpf;

public partial class SecuredPassword : UserControl
{
        public string Password
        {
            get => (string)GetValue(PasswordProperty);
            set => SetValue(PasswordProperty, value);
        }

        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register(nameof(Password), typeof(string), typeof(SecuredPassword), new PropertyMetadata(
                "", PropertyChangedCallback));

        private static void PropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is SecuredPassword securedPassword)
            {
                if(securedPassword.PbPassword.Password != securedPassword.Password)
                    securedPassword.PbPassword.Password = securedPassword.Password;
            }
        }

        public string ErrorMessage
        {
            get => (string)GetValue(ErrorMessageProperty);
            set => SetValue(ErrorMessageProperty, value);
        }

        public static readonly DependencyProperty ErrorMessageProperty =
            DependencyProperty.Register(nameof(ErrorMessage), typeof(string), typeof(SecuredPassword), new PropertyMetadata(""));

        public bool IsError
        {
            get => (bool)GetValue(IsErrorProperty);
            set => SetValue(IsErrorProperty, value);
        }

        public static readonly DependencyProperty IsErrorProperty =
            DependencyProperty.Register(nameof(IsError), typeof(bool), typeof(SecuredPassword), new PropertyMetadata(false));
        
        public SecuredPassword()
        {
            InitializeComponent();
        }

        private void PasswordBox_OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            Password = PbPassword.Password;
            IsError = false;
        }


        private void SecuredPassword_OnIsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(IsEnabled == false) StratumUiPasswordBox.SetMonitorPassword(PbPassword, false);
            else StratumUiPasswordBox.SetMonitorPassword(PbPassword, true);
        }
}