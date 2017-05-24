<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@ taglib uri="http://struts.apache.org/tags-html" prefix="html"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Setting Profile!</title>
</head>
<body>
	<a href="index.do">Home</a>
	<br />
	<br />
	<h1>Hello, Setting your profile!</h1>
	<br />

	<html:form action="setingProfileAction" focus="name">
		Name: <html:text property="name" /> <i style="color: red"><html:errors property="name" /></i>
		<p>
			Email :
			<html:text property="email" /> <i style="color: red"><html:errors property="email" /></i>
		<p>
			Address: <i style="color: red"><html:errors property="address" /></i><br />
			<html:textarea property="address" cols="50" rows="5" />
		<p>
			Sex:
			<html:checkbox property="male" value="true" /> Male

			<br /> <br />
			<html:submit value="Setting" />
	</html:form>

</body>
</html>