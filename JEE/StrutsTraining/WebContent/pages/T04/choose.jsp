<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib uri="http://struts.apache.org/tags-html" prefix="html" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Choose your sex</title>
</head>
<body>
	<a href="index.do">Home</a>
	<br />
	<br />
<h1>Choose your sex</h1><p/>
<html:form action="chooseAction" focus="name">
	Name: <html:text property="name"/> <i style="color: red"><html:errors property="name" /></i> <p/>
	Sex: <html:radio property="sex" value="true"/> Male&nbsp;&nbsp;&nbsp;
	<html:radio property="sex" value="false"/> Female<p/><p/>
	<html:submit value="Submit"/>

</html:form>
</body>
</html>