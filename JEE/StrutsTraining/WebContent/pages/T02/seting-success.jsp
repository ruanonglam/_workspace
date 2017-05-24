<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib uri="http://struts.apache.org/tags-bean" prefix="bean" %>
<%@ taglib uri="http://struts.apache.org/tags-logic" prefix="logic" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Success! <bean:write name="profileSettingForm" property="name"/> </title>
</head>
<body>
<a href="index.do">Home</a><br /><br />

<h1 style="color: blue;"><bean:message key="label.setting.header.title.success"/></h1><br/><br/>
Dear <b><bean:write name="profileSettingForm" property="name"/></b>!<p/>
Your info has update!
<p>
Name: <i><bean:write name="profileSettingForm" property="name"/></i> <p/>
Email: <i><bean:write name="profileSettingForm" property="email"/></i><p/>
<logic:equal name="profileSettingForm" property="male" value="true">Sex: <i>Nam</i></logic:equal>
<logic:equal name="profileSettingForm" property="male" value="false">Sex: <i>Nữ</i></logic:equal>
<p/>
Address: <bean:write name="profileSettingForm" property="address"/>


</body>
</html>