package vn.aftech.form;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

import javax.servlet.http.HttpServletRequest;

import org.apache.struts.action.ActionForm;
import org.apache.struts.action.ActionMapping;

public class ListStudentForm extends ActionForm {

	/**
	 * 
	 */
	private static final long serialVersionUID = 3473833484757777978L;
	private String name;
	private int age;
	private List students = Collections.synchronizedList(new ArrayList());
	
	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public int getAge() {
		return age;
	}

	public void setAge(int age) {
		this.age = age;
	}

	public Student[] getStudents() {
		return (Student[])this.students.toArray(new Student[0]);
	}
	
	public List<Student> getStudentsByList() {
		List<Student> list = new ArrayList<Student>();
		for (Student stu : getStudents()) {
			list.add(stu);
		}
		return list;
	}

	public void setStudents(final Student[] students) {
		this.students.clear();
		int length = students.length;
		for (int i = 0; i < length; i++) {
			this.students.add(students[i]);
		}
	}
	
	public void setStudents(List<Student> studentlist) {
		Student[] students = new Student[studentlist.size()];
		students = studentlist.toArray(students);
		this.setStudents(students);
	}
	
	@Override
	public void reset(ActionMapping mapping, HttpServletRequest request) {
		this.setStudents(new Student[0]);
		super.reset(mapping, request);
	}
	

}
