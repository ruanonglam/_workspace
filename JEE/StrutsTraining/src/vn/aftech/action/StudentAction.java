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
import vn.aftech.form.ListStudentForm;
import vn.aftech.form.Student;
import vn.aftech.util.Validate;

public class StudentAction extends Action {
	
	ListStudentForm listStudentForm;
	private List<Student> students = new ArrayList<>();
	private int type = 0; // 0: All, 1: Name, 2, Age

	@Override
	public ActionForward execute(ActionMapping mapping, ActionForm form,
			HttpServletRequest request, HttpServletResponse response) 
			throws Exception {
		students.clear();
		bindingData();
		listStudentForm = (ListStudentForm) form;
		listStudentForm.getStudents();
		searchCondition();
		// Search by name and age
		if (type == 0) {
			listStudentForm.setStudents(students);
		} else if (type == 1) {
			listStudentForm.setStudents(searchByName(listStudentForm.getName()));
		} else if (type == 2) {
			listStudentForm.setStudents(searchByAge(listStudentForm.getAge()));
		} else {
			listStudentForm.setStudents(searchBynameAndAge(listStudentForm.getName(), listStudentForm.getAge()));
		}
		return mapping.findForward(Common.SUCCESS);
	}
	
	private void searchCondition() {
		if (Validate.isNullOrEmptyWithoutSpace(listStudentForm.getName()) && listStudentForm.getAge() <= 0) {
			type = 0;
		} else if (Validate.isNullOrEmptyWithoutSpace(listStudentForm.getName()) && listStudentForm.getAge() > 0) {
			type = 2;
		} else if (!Validate.isNullOrEmptyWithoutSpace(listStudentForm.getName()) && listStudentForm.getAge() <= 0) {
			type = 1;
		} else if (!Validate.isNullOrEmptyWithoutSpace(listStudentForm.getName()) && listStudentForm.getAge() > 0) {
			type = 3;
		}
	}
	
	private List<Student> searchByName(String name) {
		List<Student> result = new ArrayList<Student>();
		for (Student stu : students) {
			if (stu.getName().contains(name) || name.contains(stu.getName())) {
				result.add(stu);
			}
		}
		return result;
	}
	
	private List<Student> searchByAge(int age) {
		List<Student> result = new ArrayList<Student>();
		for (Student stu : students) {
			if (stu.getAge() == age) {
				result.add(stu);
			}
		}
		return result;
	}
	
	private List<Student> searchBynameAndAge(String name, int age) {
		List<Student> result = new ArrayList<Student>();
		for (Student stu : students) {
			if (stu.getName().contains(name) || name.contains(stu.getName())) {
				if (stu.getAge() == age) {
					result.add(stu);
				}
			}
		}
		return result;
	}
	
	private void bindingData() {
		for (int i = 0; i < 50; i++) {
			Student stu = new Student();
			stu.setId("07130101" + i);
			stu.setName("Rua" + i);
			stu.setEmail("ruanonglam" + i + "@yahoo.com");
			stu.setAge(i + 5);
			students.add(stu);
		}
	}
	
}