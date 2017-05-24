<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<%@ taglib uri="http://struts.apache.org/tags-html" prefix="html"%>
<%@ taglib uri="http://struts.apache.org/tags-logic" prefix="logic" %>
<%@ taglib uri="http://struts.apache.org/tags-bean" prefix="bean" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Select Your Skill!</title>
</head>
<body>
	<a href="index.do">Home</a>
	<br />
	<br />
	<h1>Hello, select your skill!</h1>
	<br />

	<html:form action="skillAction" focus="name">
		Name: <html:text property="name" /> <i style="color: red"><html:errors property="name" /></i>
		<p>
		Skill:
		<logic:iterate id="kill" name="kill_select" >
		
			<html:multibox property="kills" value="${kill}"/><bean:write name="kill"/>&nbsp;&nbsp;
		</logic:iterate>

		<br /> <br />
		<html:submit value="Setting" />
	</html:form>

</body>
</html>