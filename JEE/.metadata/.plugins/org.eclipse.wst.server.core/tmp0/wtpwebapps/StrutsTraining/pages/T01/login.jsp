<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<%@ taglib uri="http://struts.apache.org/tags-html" prefix="html" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>T01-Login</title>
</head>
<body>
<a href="index.do">Home</a> <br/><br/>
<h1>Login Form!</h1>
<html:form action="loginAction" focus="username">
<div style="color: red;"><html:errors/></div>
	Username: <html:text property="username"/><br/><br/>
	Password: <html:password property="password"/><br/><br/>
	<html:submit value="Login!"/>

</html:form>

</body>
</html>