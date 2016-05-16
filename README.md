# nopCommerce-Custom-Header-Module

Requires a rebuild of nopCommerce.

Add CustomHeaderModule.cs to Nop.Web/Extensions/

Modify Web.Config (set modules to 'true' and add custom module)

  &lt;system.webServer&gt;

  &lt;modules runAllManagedModulesForAllRequests=&quot;true&quot;&gt;

  &lt;add name=&quot;CustomHeaderModule&quot; type=&quot;Nop.Web.Extensions.CustomHeaderModule&quot;/&gt;

