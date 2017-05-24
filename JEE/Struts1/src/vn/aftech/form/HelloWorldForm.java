package vn.aftech.form;

import org.apache.struts.action.ActionForm;

public class HelloWorldForm extends ActionForm {
	
	private static final long serialVersionUID = 1L;
	private String hello = null;

	public HelloWorldForm() {
		super();
		this.hello = "Trinh Van Qui";
	}

	public String getHello() {
		return hello;
	}

	public void setHello(String hello) {
		this.hello = hello;
	}
	

}
