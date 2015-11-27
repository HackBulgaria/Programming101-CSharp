# Source Control Systems - Git and TFS

## Some Git fun

Create a new directory and create a new local Git repo there.

Make a new file called `hello` with the following content:

```
This is line one.
This is line two.
This is line three.
This is line four.
```

Now commit. You get an error? Did you remember to `add`?

Now create a new branch called `panda` and switch to it.

Change the second line of `hello` with `Uh, I forgot how to count!` and add a fifth line `This is line five.`.

Commit this and switch back to the master branch.

Now change the third line of `hello` with `I am number three.` and remove the fourth line. Commit.

We will now simulate something called a **merge conflict**. A merge conflict happens when we attempt to merge two files when it is not obvious how to merge them (e.g. when the file has been modified from two different branches as in this case).

While on the `master` branch, merge it with the `panda` branch. You will see the error.

In order to fix the merge conflict, we need to use a merge tool. First make sure you have configured git to use [Visual Studio as a merge tool](https://github.com/HackBulgaria/Programming101-CSharp/blob/master/week02/README.md#working-with-git)

Now run `git mergetool` and start Visual Studio merge tool should be started. Get familiar with the interface. We want the file to look like this after the merge:

```
This is line one.
Uh, I forgot how to count!
I am number three.
This is line five.
```
### Commit it all to GitHub

This is a big one. Go to our repository and note how our directories are structured.

```
|--week01
|  |--1.Tuesday
|  |--2.Thursday
|  |--3.Saturday
|
|--week02
   |--1.Tuesday
   |--2.Thursday
   |--3.Saturday
```

Your task is to create a GitHub repo of your own. Add all of your solutions to your repo and **use the same directory structure**.

__Hint: Instead of manually creating the directories, you can clone our repo and then integrate it with your GitHub repo.__

You will need to push all of your solutions to GitHub from now on. We will sometimes review your code and give you feedback directly through GitHub.

## Working with TFS

Create a free account at [Visual Studio Online](https://www.visualstudio.com/products/visual-studio-team-services-vs). Create a TFS repository there.

Make sure the TFS version control plugin is enabled in Visual Studio.

Connect to Visual Studio Online from Visual Studio: https://www.visualstudio.com/get-started/code/share-your-code-in-tfvc-vs

Create a new solution inside your working directory and add it to the source control. Get familiar with the source control interface
