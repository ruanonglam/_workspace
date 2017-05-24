package vn.aftech.action;

import java.util.ArrayList;
import java.util.List;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.struts.action.Action;
import org.apache.struts.action.ActionForm;
import org.apache.struts.action.ActionForward;
import org.apache.struts.action.ActionMapping;

import vn.aftech.common.Common;

public class SkillPageAction extends Action {
	
	private static final String KEY_KILL = "kill_select";
	
	@Override
	public ActionForward execute(ActionMapping mapping, ActionForm form,
			HttpServletRequest request, HttpServletResponse response)
			throws Exception {
		List<String> skills = bindingData();
		request.setAttribute(KEY_KILL, skills);
		
		return mapping.findForward(Common.SUCCESS);
	}
	
	private List<String> bindingData() {
		List<String> skills = new ArrayList<>();
		skills.add("Java");
		skills.add("PHP");
		skills.add("C#");
		skills.add("VC6");
		skills.add("VB6");
		skills.add("VB.NET");
		return skills;
	}
	
}
