# 11 Tips for Visual Studio 2022
This is the repository for the LinkedIn Learning course 11 Tips for Visual Studio 2022. The full course is available from [LinkedIn Learning][lil-course-url].

![11 Tips for Visual Studio 2022][lil-thumbnail-url] 

If you need to work in Microsoft Visual Studio, this course can make your job simpler, faster, and more interesting. Instructor Walt Ritscher explores eleven Visual Studio tips, starting with how to use the new IEnumerable data visualizer. Walt goes over adding columns for ultrawide monitors, automatically saving files, and suppressing the “run the last successful build” dialog message. He explains the Developer Command Prompt for PowerShell, as well as how to create a project from existing files, squash and combine Git commits, and use keyboard shortcuts to find information.  Plus, Walt walks you through using the VS command-line tool to manage Visual Studio, automatically tracking your active document, and previewing XML documentation.

## Instructions
This repository has branches for each of the videos in the course. You can use the branch pop up menu in github to switch to a specific branch and take a look at the course at that stage, or you can add `/tree/BRANCH_NAME` to the URL to go to the branch you want to access.

## Branches
The branches are structured to correspond to the videos in the course. The naming convention is `Tip#_MOVIE#`. As an example, the branch named `Tip03` corresponds to the third movie of chapter one. 

When switching from one exercise files branch to the next after making changes to the files, you may get a message like this:

    error: Your local changes to the following files would be overwritten by checkout:        [files]
    Please commit your changes or stash them before you switch branches.
    Aborting

To resolve this issue:
	
    Add changes to git using this command: git add .
	Commit changes using this command: git commit -m "some message"


### Instructor

Walt Ritscher 
                            
Senior Staff Author

                            

Check out my other courses on [LinkedIn Learning](https://www.linkedin.com/learning/instructors/walt-ritscher).

[lil-course-url]: https://www.linkedin.com/learning/11-tips-for-visual-studio-2022
[lil-thumbnail-url]: https://cdn.lynda.com/course/3215115/3215115-1659468492758-16x9.jpg
