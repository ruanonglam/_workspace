<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib uri="http://struts.apache.org/tags-bean" prefix="bean" %>
<%@ taglib uri="http://struts.apache.org/tags-logic" prefix="logic" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Hello <bean:write name="skillForm" property="name" />!</title>
</head>
<body>
	<a href="index.do">Home</a>
	<br />
	<br />
	<h1>Hello <bean:write name="skillForm" property="name" />!, your skill below!</h1>
	<br />
	
	<ol>
	<logic:iterate id="skill" name="skillForm" property="kills">
		<li><bean:write name="skill"/></li>
	</logic:iterate>
	</ol>
</body>
</html>