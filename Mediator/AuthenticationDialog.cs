using System;
using System.Collections.Generic;

namespace Mediator
{
    public class AuthenticationDialog : IMediator
    {
        private Button _loginButton;
        private Button _registerButton;

        private TextInput _loginInput;
        private PasswordInput _passwordInput;
        private PasswordInput _repeatPasswordInput;

        private Checkbox _isLoginOrRegister;

        public AuthenticationDialog()
        {
            // Авторизация
            _loginInput = new TextInput("Поле ввода логина", this);
            _passwordInput = new PasswordInput("Поле ввода Пароля", this);
            _loginButton = new Button("Кнопка авторизации", this);

            // Регистрация
            _repeatPasswordInput = new PasswordInput("Поле повторения ввода пароля", this);
            _registerButton = new Button("Кнопка авторизации", this);

            // Default - авторизация
            _isLoginOrRegister = new Checkbox(null, this);
            _isLoginOrRegister.IsVisible = true;
            _isLoginOrRegister.Value = true;

            if (_isLoginOrRegister.Value) SetAuthorizeVisibility();
            else SetRegisterVisibility();
        }

        /// <summary>
        /// Обработка видимости элементов
        /// </summary>
        /// <param name="sender"></param>
        public void Notify(Component sender)
        {
            // Сюда выносятся хаотичные связи классов
            if (sender == _isLoginOrRegister)
            {
                if (_isLoginOrRegister.Value) SetAuthorizeVisibility();
                else SetRegisterVisibility();
            }
        }

        /// <summary>
        /// Устанавливает видимость элементов при авторизации
        /// </summary>
        public void SetAuthorizeVisibility()
        {
            _loginInput.IsVisible = true;
            _passwordInput.IsVisible = true;
            _loginButton.IsVisible = true;

            _repeatPasswordInput.IsVisible = false;
            _registerButton.IsVisible = false;
        }

        /// <summary>
        /// Устанавливает видимость элементов при регистрации
        /// </summary>
        public void SetRegisterVisibility()
        {
            _loginInput.IsVisible = true;
            _passwordInput.IsVisible = true;
            _loginButton.IsVisible = false;

            _repeatPasswordInput.IsVisible = true;
            _registerButton.IsVisible = true;
        }

        public void ShowMenu()
        {
            var components = new List<Component> { _loginInput, _passwordInput, _repeatPasswordInput, _loginButton, _registerButton };

            while (true)
            {
                var title = _isLoginOrRegister.Value ? "== Авторизация ==" : "== Регистрация ==";
                Console.WriteLine(new string(' ', 4) + title + "\n" + new string('-', 25));

                foreach (var c in components)
                {
                    if (c.IsVisible)
                        Console.WriteLine(" - " + c.Title);
                }

                Console.WriteLine("\nДля смены формы нажмите любую клавишу...\n");
                Console.ReadKey();
                Console.Clear();
                _isLoginOrRegister.Click();
            }
        }
    }
}
