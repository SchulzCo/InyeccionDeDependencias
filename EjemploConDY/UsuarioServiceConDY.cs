namespace InyeccionDeDependencias.EjemploConDY
{
    public class UsuarioServiceConDY
    {
        private IEmailServiceConDY _emailServiceConDY;

        public UsuarioServiceConDY(IEmailServiceConDY emailServiceConDY)
        {
            _emailServiceConDY = emailServiceConDY;
        }
        public bool enviarNotificacionuruarioConDY(string email) {

            _emailServiceConDY.Enviar(email, "Notificacion"); 
            return true;

        }

    }
}
