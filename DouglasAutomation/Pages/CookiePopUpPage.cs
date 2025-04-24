using OpenQA.Selenium;

public class CookiePopupPage : BasePage
{
    private readonly By shadowHost = By.CssSelector("#usercentrics-root");
    private readonly string acceptButtonText = "alle erlauben";

    public void AcceptCookies()
    {
        try
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            string script = $@"
                const host = document.querySelector('{shadowHost.ToString().Replace("By.CssSelector: ", "")}');
                if (!host || !host.shadowRoot) return 'Shadow root not ready';

                const btns = host.shadowRoot.querySelectorAll('button');
                for (let btn of btns) {{
                    if (btn.textContent.toLowerCase().includes('{acceptButtonText}')) {{
                        btn.click();
                        return 'Clicked: ' + btn.textContent;
                    }}
                }}
                return 'Accept button not found';
            ";

            var result = js.ExecuteScript(script);
            
        }
        catch (Exception ex)
        {
          
        }
    }
}


