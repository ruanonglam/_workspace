package vn.aftech.form;

import javax.servlet.http.HttpServletRequest;

import org.apache.struts.action.ActionErrors;
import org.apache.struts.action.ActionForm;
import org.apache.struts.action.ActionMapping;
import org.apache.struts.action.ActionMessage;

import vn.aftech.util.Validate;

public class LoginForm extends ActionForm {
	
	private static final long serialVersionUID = -5352082620719890867L;
	
	private String username;
	private String password;
	public String getUsername() {
		return username;
	}
	public void setUsername(String username) {
		this.username = username;
	}
	public String getPassword() {
		return password;
	}
	public void setPassword(String password) {
		this.password = password;
	}
	
	@Override
	public ActionErrors validate(ActionMapping mapping,
			HttpServletRequest request) {
		ActionErrors errors = new ActionErrors();
		if (Validate.isNullOrEmptyWithoutSpace(username)) {
			errors.add("username", new ActionMessage("errors.login.username.required","Username"));
		}
		return errors;
	}
	
	@Override
	public void reset(ActionMapping mapping, HttpServletRequest request) {
		this.username = null;
		super.reset(mapping, request);
	}
}
