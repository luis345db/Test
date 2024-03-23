namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void ValidacionPassword()
        {
            string password = "test";
            ValidacionContrase�a validador = new ValidacionContrase�a();
            bool Validacion = validador.Contrase�aValidar(password);
            Assert.False(Validacion);
        }

        [Fact]
        public void ValidacionPassword_CaracteresSpecialesRequeridos()
        {
            string password = "test123";
            ValidacionContrase�a validador = new ValidacionContrase�a();
            bool Validacion = validador.Contrase�aValidar(password);
            Assert.False(Validacion);
        }
    }

    internal class ValidacionContrase�a
    {
        public bool Contrase�aValidar(string password)
        {
            return password.Length >= 8 && ContieneCaracteresEspeciales(password);
        }

        private bool ContieneCaracteresEspeciales(string password)
        {
            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}


