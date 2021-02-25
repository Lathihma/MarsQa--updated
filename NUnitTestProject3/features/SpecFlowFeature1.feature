Feature:Login
	Login to Skillswap

@mytag
Scenario Outline: Perform Login 
	Given launch the application
	And Click on login button
	And Enter the following details
	     | Emailaddress                  |  Password  |
		 | lathishmasuvarnaa@gmail.com   | lathishma  |
    And    click on login button
	Then  should see the profile page

Feature: Language
	     Adding language details under language tab
@mytag
Scenario Outline: successful save
	  Given To enter the languages set tab
	   And when you enter add feature for language
	  When you choose the option and click on add
	         | language  |     language level    |
	         | english   |     conversational    |
	  Then  the details will be saved


Feature:  Skills
	     adding features to the Skills tab
@mytag
Scenario Outline: successful Add to skill tab  
	  Given To enter the skill set form 
	  And  I click on add New button
	  And  I fill the details under the skill tab
	  When  you click on add button for skills
	              | skill |  level    |
	              | API   | Beginner  |



