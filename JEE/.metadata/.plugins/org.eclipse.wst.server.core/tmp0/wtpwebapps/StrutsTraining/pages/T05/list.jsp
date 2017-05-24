<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib uri="http://struts.apache.org/tags-html" prefix="html" %>
<%@ taglib uri="http://struts.apache.org/tags-logic" prefix="logic" %>
<%@ taglib uri="http://struts.apache.org/tags-bean" prefix="bean" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Student Finders!</title>
</head>
<body>
	<a href="index.do">Home</a>
	<br />
	<br />
	<h1>Students finder!</h1><p/>
	<html:form action="listSearch" focus="name">
		Name: <html:text property="name"/><p/>
		Age: <html:text property="age"/><p/><br/>
		<html:submit value="Finder"/>
		<hr>
		<table width="100%" border="1" cellspacing="0">
			<tr>
				<th width="5%">No.</th>
				<th width="5%">&nbsp;</th>
				<th width="10%">ID</th>
				<th width="25%">Name</th>
				<th width="35%">Email</th>
				<th width="10%">Age</th>
			</tr>
			<logic:iterate name="studentListForm" property="students" id="student" indexId="index">
				<tr>
					<td><bean:write name="index" /> </td>
					<td><html:checkbox name="student" property="checked"/></td>
					<td><html:link action="listSearch" paramName="studentListForm" paramProperty="name" paramId="sId"><bean:write name="student" property="id"/> </html:link></td>
					<td><bean:write name="student" property="name"/></td>
					<td><bean:write name="student" property="email"/></td>
					<td><bean:write name="student" property="age"/></td>
				</tr>
			</logic:iterate>
			
		</table>
		
	</html:form>
</body>
</html>