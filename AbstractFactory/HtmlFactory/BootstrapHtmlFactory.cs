namespace AbstractFactory
{
    /// <summary>
    /// Генерация bootstrap HTML-страницы
    /// </summary>
    public class BootstrapHtmlFactory : IHtmlFactory
    {
        public string CreateHead()
        {
            return @"<!doctype html><head>
 <!-- Bootstrap CSS -->
<link href='https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css' 
rel='stylesheet' integrity='sha384-eOJMYsd53ii+scO/bJGFsiCZc+5NDVN2yr8+0RDqr0Ql0h+rP48ckxlpbzKgwra6' crossorigin='anonymous'>
</head";
        }

        public string CreateBody()
        {
            return "<body><h1>Bootrap page!</h1></body>";
        }

        public string CreateFooter()
        {
            return "</html>";
        }

    }
}
