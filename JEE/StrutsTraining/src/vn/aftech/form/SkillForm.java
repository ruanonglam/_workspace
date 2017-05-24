package vn.aftech.form;

import org.apache.struts.action.ActionForm;

public class SkillForm extends ActionForm {

	private static final long serialVersionUID = 1835808616474992478L;
	private String name;
	private String[] kills;

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String[] getKills() {
		return kills;
	}

	public void setKills(String[] kills) {
		this.kills = kills;
	}

}
