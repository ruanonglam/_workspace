<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    <%@ taglib uri="http://struts.apache.org/tags-bean" prefix="bean" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Login Failed!</title>
</head>
<body>
<h1>Hello <bean:write name="loginForm" property="username"/>!</h1>
<h2 style="color: red;"><bean:message key="message.login.action.failed"/></h2>
<br/><br/>
<a href="index.do">Home</a> <br/><br/>
</body>
</html>