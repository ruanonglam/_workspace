<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@ taglib uri="http://struts.apache.org/tags-bean" prefix="bean"%>
<%@ taglib uri="http://struts.apache.org/tags-html" prefix="html"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Hello <bean:write name="profileSettingForm" property="name" /> !
</title>
</head>
<body>
	<a href="index.do">Home</a><br /><br />
	<h1 style="color: blue;"><bean:message key="label.setting.header.title" /></h1><p/>
	
	Name: <bean:write name="profileSettingForm" property="name"/><p/>
	Email: <bean:write name="profileSettingForm" property="email"/><p/>
	Address: <bean:write name="profileSettingForm" property="address"/><p/>
	You are male?: <bean:write name="profileSettingForm" property="male"/>
	<p>
	<html:form action="settingProfileConfirmAction">
		<html:hidden property="name"/>
		<html:hidden property="email"/>
		<html:hidden property="address"/>
		<html:hidden property="male"/>
		<html:submit value="Edit" property="Edit" /> <html:submit value="Submit" property="Submit" />
	</html:form>
</body>
</html>