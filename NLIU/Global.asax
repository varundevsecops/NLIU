<%@ Application Language="C#" %>

<script runat="server">

    void Application_EndRequest(Object sender, EventArgs e)
    {
        if (Response.Cookies.Count > 0)
            foreach (string s in Response.Cookies.AllKeys)
                if (s == System.Web.Security.FormsAuthentication.FormsCookieName ||
                s.ToLower().Equals("asp.net_sessionid"))
                    Response.Cookies[s].HttpOnly = false;
    }
        
    void Session_Start(object sender, EventArgs e)
    {
        
        
    }
    

    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup

    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs

    }

  

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
    
       
</script>
