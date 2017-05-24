package vn.aftech.form;

import javax.servlet.http.HttpServletRequest;

import org.apache.struts.action.ActionErrors;
import org.apache.struts.action.ActionForm;
import org.apache.struts.action.ActionMapping;
import org.apache.struts.action.ActionMessage;

import vn.aftech.util.Validate;

public class ProfileSettingForm extends ActionForm {

	private static final long serialVersionUID = 1L;
	private String name;
	private String email;
	private String address;
	private boolean male;

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	public String getAddress() {
		return address;
	}

	public void setAddress(String address) {
		this.address = address;
	}

	public boolean isMale() {
		return male;
	}

	public void setMale(boolean male) {
		this.male = male;
	}
	
	@Override
	public ActionErrors validate(ActionMapping mapping,
			HttpServletRequest request) {
		ActionErrors errors = new ActionErrors();
		if (Validate.isNullOrEmptyWithoutSpace(name)) {
			errors.add("name", new ActionMessage("error.setting.name.required"));
		}
		
		if (Validate.isNullOrEmptyWithoutSpace(email)) {
			errors.add("email", new ActionMessage("error.setting.email.required"));
		}
		
		if (Validate.isNullOrEmptyWithoutSpace(address)) {
			errors.add("address", new ActionMessage("error.setting.email.required"));
		}
		
		return errors;
	}

	@Override
	public void reset(ActionMapping mapping, HttpServletRequest request) {
		this.male = false;
		super.reset(mapping, request);
	}
}
