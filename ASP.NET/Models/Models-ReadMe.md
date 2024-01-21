# Models Overview

This document provides a quick overview of the models used in the Razor/Blazor Project with Entity Framework Core.

## User Model

- **UserId**: `int`
- **Username**: `string`
- **Email**: `string`
- **Posts**: Collection of `Post`
- **Comments**: Collection of `Comment`

Represents a user of the application.

## Post Model

- **PostId**: `int`
- **Title**: `string`
- **Content**: `string`
- **DateCreated**: `DateTime`
- **UserId**: `int`
- **User**: `User`
- **Comments**: Collection of `Comment`
- **PostTags**: Collection of `PostTag`

Represents a blog post or article. Each post is associated with a user and can have multiple comments and tags.

## Comment Model

- **CommentId**: `int`
- **Content**: `string`
- **DateCreated**: `DateTime`
- **UserId**: `int`
- **User**: `User`
- **PostId**: `int`
- **Post**: `Post`

Represents a comment on a post. Each comment is linked to a user and a post.

## Category Model

- **CategoryId**: `int`
- **Name**: `string`
- **Posts**: Collection of `Post`

Used to categorize posts. Each post can belong to one category.

## Tag Model

- **TagId**: `int`
- **Name**: `string`
- **PostTags**: Collection of `PostTag`

Represents a tag for a post. Posts can have multiple tags.

## PostTag Model (Junction Table)

- **PostId**: `int`
- **Post**: `Post`
- **TagId**: `int`
- **Tag**: `Tag`

A junction table for a many-to-many relationship between `Post` and `Tag`.

---

These models are the backbone of the application's data structure and are used for managing users, posts, comments, categories, and tags.
