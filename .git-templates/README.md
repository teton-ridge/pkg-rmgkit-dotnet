# Git Hooks

This directory contains Git hooks that are applied to the repository to maintain consistent behavior across all developers.

## Hooks

### post-checkout
- Configures `push.followTags` to `false` to prevent accidental pushing of tags
- Tags are managed by CI/CD pipelines only

## How it works
These hooks are automatically executed when specific Git actions are performed. The `post-checkout` hook runs after a developer checks out the repository, setting up the proper Git configuration.

## For developers
- If you clone this repository, these hooks will automatically be applied
- To manually apply these settings: `git config push.followTags false`
- Never manually push tags - tags are managed by the CI/CD pipeline 