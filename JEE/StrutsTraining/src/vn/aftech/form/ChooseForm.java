package vn.aftech.form;

import javax.servlet.http.HttpServletRequest;

import org.apache.struts.action.ActionErrors;
import org.apache.struts.action.ActionForm;
import org.apache.struts.action.ActionMapping;
import org.apache.struts.action.ActionMessage;

import vn.aftech.util.Validate;

public class ChooseForm extends ActionForm {

	private static final long serialVersionUID = 6882987004642689723L;
	private String name;
	private boolean sex;

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public boolean isSex() {
		return sex;
	}

	public void setSex(boolean sex) {
		this.sex = sex;
	}

	@Override
	public void reset(ActionMapping mapping, HttpServletRequest request) {
		this.sex = true;
		super.reset(mapping, request);
	}

	@Override
	public ActionErrors validate(ActionMapping mapping,
			HttpServletRequest request) {
		ActionErrors errors = new ActionErrors();
		if (Validate.isNullOrEmptyWithoutSpace(name)) {
			errors.add("name", new ActionMessage("error.choose.name.required"));
		} else if (!Validate.isOverMaxlength(name, 5)) {
			errors.add("name", new ActionMessage("error.choose.name.maxlength"));
		}
		return errors;
	}

}
